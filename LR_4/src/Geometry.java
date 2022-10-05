import java.util.List;

public class Geometry {

    protected String name;
    protected List<Integer> pointX;
    protected List<Integer> pointY;
    protected List<Integer> angles;
    protected List<Integer> lines;
    public Geometry(String nname, List<Integer> nX, List<Integer> nY, List<Integer> nangles,List<Integer> nlines){
        name = nname;
        pointX = nX;
        pointY = nY;
        angles = nangles;
        lines = nlines;
    }
    public String getName(){
        return this.name;
    }
    public void setName(String gname){
        this.name = gname;
    }
}
