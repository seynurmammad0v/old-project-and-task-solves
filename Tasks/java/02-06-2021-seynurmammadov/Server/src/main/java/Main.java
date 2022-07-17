import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Properties;

public class Main {
    public static void main(String[] args) throws IOException {
        Properties properties = new Properties();
        properties.load(Files.newBufferedReader(Path.of("src/main/resources/folder_dir.config")));
        ServerSocket ss = new ServerSocket(5555);
        Socket s = ss.accept();
        DataInputStream dis = new DataInputStream(s.getInputStream());
        while (true) {
            byte[] message = new byte[dis.readInt()];
            dis.read(message);
            FileOutputStream fos = new FileOutputStream(properties.get("upload") + dis.readUTF(), true);
            fos.write(message);
            fos.close();
        }
    }
}

