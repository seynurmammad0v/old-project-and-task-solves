import java.sql.*;
import java.util.Properties;

public class ConnectionDb {
    public static void main(String[] args) throws SQLException {
//        String url = "jdbc:postgresql://localhost/code";
//        Properties props = new Properties();
//        props.setProperty("user","postgres");
//        props.setProperty("password","123456");
//        Connection conn = DriverManager.getConnection(url, props);


        String url = "jdbc:postgresql://localhost/code?user=postgres&password=123456";
        Connection conn = DriverManager.getConnection(url);

        PreparedStatement st = conn.prepareStatement("select *  from logs where id =?");
        st.setInt(1, 124);
        ResultSet rs = st.executeQuery();
        while (rs.next())
        {
            System.out.print("Column: ");
            System.out.println(rs.getString(3));
        }
        rs.close();
        st.close();


    }
}
