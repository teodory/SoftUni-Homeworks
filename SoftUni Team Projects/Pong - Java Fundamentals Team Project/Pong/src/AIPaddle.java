import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class AIPaddle {
    int x;
    int y;
    int width = 15;
    int height = 40;
    public static int speed = 1;//Adjust AI paddle speed

    public static boolean isTwoPlayer = false;

    Rectangle boundingBox;

    //is the paddle moving up or down
    boolean goingUp = false;
    boolean goingDown = false;

    public AIPaddle(int x, int y) {
        this.x = x;
        this.y = y;

        boundingBox = new Rectangle(x, y, width, height);
        boundingBox.setBounds(x, y, width, height);
    }

    public void tick(Game game) {
        boundingBox.setBounds(x, y, width, height);
         //is this a two player game or a player vs. AI
        if(isTwoPlayer==true){
            speed = 2;
        }
        if (!isTwoPlayer) {
            if (game.ball.y < y && y >= 0) {
                y -= speed;
            }

            else if (game.ball.y > y && y + height <= game.getHeight()) {
                y += speed;
            }
        }

        else {
            if (goingUp && y >= 0) {
                y -= speed;

            } else if (goingDown && y + height < game.getHeight()) {
                y += speed;
            }

        }
    }

    public void render(Graphics g) {
        g.setColor(Color.GREEN);
        g.fillRect(x, y, width, height);
    }
}
