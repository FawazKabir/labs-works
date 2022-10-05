import java.util.List;

public class Triangle extends Geometry{
    public Triangle(String nname, List<Integer> nX, List<Integer> nY, List<Integer> nangles, List<Integer> nlines) {
        super(nname, nX, nY, nangles, nlines);
    }
    public String getPoints(List<Integer> nX,List<Integer>nY){
        String str = new String();
        for (int i=0;i<3;i++){
            str = nX.get(i).toString() + ","+nY.get(i).toString()+"; ";
        }
        return str;
    }
    @Override
    public String getName(){
        String strok = new String();
        String lns = new String();
        String angls = new String(); 
        strok = getPoints(this.pointX,this.pointY);
        for(int i=0;i<this.angles.size();i++){ angls = this.angles.get(i).toString();}
        for(int i=0;i<this.lines.size();i++){ lns = this.lines.get(i).toString();}
        return "Треугольник: "+ this.name +
            "\n Координаты точек: " +  strok +
            "\n Углы треугольника: " + angls +
            "\n Длина отрезков: " + lns;
    }
}
