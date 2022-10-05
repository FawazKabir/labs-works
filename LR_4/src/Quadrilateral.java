import java.util.List;

public class Quadrilateral extends Geometry{
    public Quadrilateral(String nname, List<Integer> nX, List<Integer> nY, List<Integer> nangles,List<Integer> nlines){
        super(nname, nX, nY, nangles, nlines);
    }
    @Override
    public String getName(){
        return "Четырёхугольник: "+ this.name;
    }
    public String getPoints(List<Integer> nX,List<Integer>nY){
        String str = new String();
        for (int i=0;i<4;i++){
            str = nX.get(i).toString() + ","+nY.get(i).toString()+"; ";
        }
        return str;
    }
}
