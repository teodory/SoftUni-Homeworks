import javax.tools.JavaCompiler;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.util.Random;

public class Ball {
    int x, y;
    int size = 16;
    int vx, vy;
    int speed = 2;

    Rectangle boundingBox;

    public Ball(int x, int y) {
        this.x = x;
        this.y = y;
        vx = speed;
        vy = speed;

        boundingBox = new Rectangle(x, y, size, size);
        boundingBox.setBounds(this.x, this.y, this.size, this.size);
    }

    public void tick(Game game) {
        boundingBox.setBounds(x, y, size, size);
        Random rand = new Random();



        if (x <= 0) {
            game.p2Score++;
            java.awt.Toolkit.getDefaultToolkit().beep();
            vx = speed;

            if(Game.ai.isTwoPlayer==false) {                   //if the game isnt PvP
                AIPaddle.speed = rand.nextInt((2 - 1) + 1) + 1;//set a random speed for the AI paddle
            }


        }

        else if (x + size >= game.getWidth()) {
            game.p1Score++;
            java.awt.Toolkit.getDefaultToolkit().beep();
            vx = -speed;
            int counter=0;
            counter++;

            if(Game.ai.isTwoPlayer==false) {
                AIPaddle.speed = rand.nextInt((2 - 1) + 1) + 1;
            }


        }
        if (y <= 0) {
            vy = speed;
            if(Game.ai.isTwoPlayer==false) {
                AIPaddle.speed = rand.nextInt((2 - 1) + 1) + 1;
            }

        }

        else if (y + size >= game.getHeight()) {
            vy = -speed;

            if(Game.ai.isTwoPlayer==false) {
                AIPaddle.speed = rand.nextInt((2 - 1) + 1) + 1;
            }

            }

        x += vx;
        y += vy;
        paddleColide(game);

    }

    private void paddleColide(Game game) {

        if (boundingBox.intersects(game.player.boundingBox)) {
            vx = speed;

        }

        else if (boundingBox.intersects(game.ai.boundingBox)) {
            vx = -speed;

        }
    }
    
    public void render(Graphics g) {
        g.setColor(Color.RED);
        g.fillOval(x, y, size, size);
    }
}