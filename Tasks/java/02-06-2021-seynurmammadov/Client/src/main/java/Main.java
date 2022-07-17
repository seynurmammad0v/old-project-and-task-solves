import java.io.*;
import java.net.Socket;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Arrays;
import java.util.List;
import java.util.Properties;

public class Main {

    public static void main(String[] args) throws IOException, InterruptedException {
        Properties properties = new Properties();
        try {
            properties.load(Files.newBufferedReader(Path.of("src/main/resources/folder_dir.config")));
        } catch (IOException e) {
            e.printStackTrace();
        }
        String read = properties.getProperty("read");
        String archive = properties.getProperty("archive");

        Socket s = new Socket("localhost", 5555);

        File dir = new File(read);
        while (true) {
            DataOutputStream dout = new DataOutputStream(s.getOutputStream());
            List<File> files = Arrays.asList(dir.listFiles());
            if (files.size() > 0) {
                sendImg(s, files.get(0), archive, dout);
            }
        }
    }


    public static void sendImg(Socket s, File fileImage, String archive, DataOutputStream dout) throws IOException {
        InputStream inp = new FileInputStream(fileImage.getAbsolutePath());
        byte[] buffer = new byte[100];
        int readData;
        while ((readData = inp.read(buffer)) != -1) {
            dout.writeInt(readData);
            dout.write(buffer, 0, readData);
            dout.writeUTF(fileImage.getName());
        }
        inp.close();
        File move = new File(archive + fileImage.getName());
        fileImage.renameTo(move);
    }
}
