import java.util.Arrays;
import java.util.Vector;

public class App {
    public static void main(String[] args) throws Exception {
        Vector<Geometry> allGeometry = new Vector<Geometry>();
        allGeometry.add(new Geometry("Геометрия",
        Arrays.asList(0),
        Arrays.asList(0),
        Arrays.asList(0),
        Arrays.asList(0)));
        allGeometry.add(new Quadrilateral("ABCD",
        Arrays.asList(1,2,3,4),
        Arrays.asList(5,6,7,8),
        Arrays.asList(35,40,55,50),
        Arrays.asList(10,8,5,6)));
        allGeometry.add(new Square("MNKL",
        Arrays.asList(8,7,4,2),
        Arrays.asList(3,8,7,1),
        Arrays.asList(35,40,55,50),
        Arrays.asList(10,8,5,6)));
        allGeometry.add(new Romb("PQRS",
        Arrays.asList(4,2,8,6),
        Arrays.asList(1,2,6,5),
        Arrays.asList(50,40,55,35),
        Arrays.asList(5,6,11,9)));
        allGeometry.add(new Triangle("VWZX",
        Arrays.asList(4,2,8),
        Arrays.asList(1,2,6),
        Arrays.asList(60,30,90),
        Arrays.asList(5,12,8)));
        for (int i=0;i<allGeometry.size();i++){
            System.out.println(allGeometry.get(i).getName());
        }
    }
}

