import java.util.List;

public class Romb extends Quadrilateral{
    public Romb(String nname, List<Integer> nX, List<Integer> nY, List<Integer> nangles, List<Integer> nlines) {
        super(nname, nX, nY, nangles, nlines);
    }    
    @Override
    public String getName(){
        String strok = new String();
        String angls = new String(); 
        strok = getPoints(this.pointX,this.pointY);
        for(int i=0;i<this.angles.size();i++){ angls = this.angles.get(i).toString();}
        return "Ромб: "+ this.name +
            "\n Координаты точек: " +  strok +
            "\n Углы ромба: " + angls +
            "\n Длина отрезков: " + this.lines.get(1).toString();
    }
    
}