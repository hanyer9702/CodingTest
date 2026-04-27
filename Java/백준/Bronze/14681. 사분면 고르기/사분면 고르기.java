import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        int x = a.nextInt();
        int y = a.nextInt();
        
        if(x > 0) {
			if(y > 0) {
				System.out.println("1");
			} else if(y < 0) {
				System.out.println("4");
			} 
		} else if (x < 0) {
			if(y > 0) {
				System.out.println("2");
			} else if(y < 0) {
				System.out.println("3");
			} 
		} 
    }
}