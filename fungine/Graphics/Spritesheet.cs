namespace el_sime.Fungine.Graphics;

class Spritesheet
{
    public string resourceName {get; private set;}
    public int cols {get; private set;}
    public int rows {get; private set;}
    public int startingFrame {get; private set;}
    public int currrentFrame {get; private set;}

    public int maxFrames {get; private set;}
    // TODO find out how to check for the resource
    // throw an exception if resource not found 

    public Spritesheet(string resourceName, int cols, int rows, int maxFrames)
    {
        this.resourceName = resourceName;
        this.cols = cols;
        this.rows = rows;
        this.maxFrames = maxFrames;
        this.currrentFrame = startingFrame;

    }
}