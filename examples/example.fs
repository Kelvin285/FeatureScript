script:test {
	import javax.swing.JFrame
	import java.awt.Graphics
	import java.awt.Color
	import java.util.Random
	import java.awt.Image
	
	setvar frame:new JFrame()
	setvar random:new Random()
	
	setvar ball_x:250
	setvar ball_y:250
	setvar width:500
	setvar height:500
	
	setvar dirX:random.nextInt(2) * 2 - 1
	setvar dirY:random.nextInt(2) * 2 - 1
	
	function init {
		frame = new JFrame();
		frame.setSize(500, 500);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setLocationRelativeTo(null);
		frame.setVisible(true);
		
		setvar image:frame.createVolatileImage(500, 500);
		
		
		
		while (true) {
			run tick
			setvar g:image.getGraphics();
			run render :g
			g = frame.getGraphics();
			g.drawImage(image, 0, 0, 500, 500, null);
			g.dispose();
		}
	}
	
	function tick {
		ball_x += dirX * 5;
		ball_y += dirY * 5;
		if (ball_x > 500) { dirX = -1 }
		if (ball_x < 0) { dirX = 1 }
		
		if (ball_y > 500) { dirY = -1 }
		if (ball_y < 0) { dirY = 1 }
	}
	
	function render g {
		if (g != null) {
			g.setColor(Color.WHITE);
			g.fillRect(0, 0, 500, 500);
			g.setColor(Color.BLUE);
			g.fillRect(ball_x, ball_y, 50, 50);
		}
	}
}