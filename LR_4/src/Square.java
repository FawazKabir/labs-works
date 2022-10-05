import java.util.List;

public class Square extends Quadrilateral{
    public Square(String nname, List<Integer> nX, List<Integer> nY, List<Integer> nangles,List<Integer> nlines){
        super(nname, nX,nY,nangles,nlines);
    }
    @Override
    public String getName(){
        String strok = new String();
        strok = getPoints(this.pointX,this.pointY);
        return "Квадрат: "+ this.name +
            "\n Координаты точек: " +  strok +
            "\n Угол: 90 гр." +
            "\n Длина отрезков: " + this.lines.get(1).toString();
    }
}