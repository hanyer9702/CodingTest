import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner a = new Scanner(System.in);
		int scan = a.nextInt();
		int max = a.nextInt();
		int num[] = new int[scan];
		int minNum = 0;
		
        for(int i=0; i<scan; i++){
            int newNum = a.nextInt();
            if(newNum < max) {
            	num[minNum] = newNum;
            	minNum++;
            }
        }
        for(int j=0; j<minNum; j++) {
        	System.out.print(num[j]+" ");
        }
	}

}