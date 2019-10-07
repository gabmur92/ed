import java.util.Scanner;
public class JAdivina {

	public static void main(String[] args) {
		Scanner tcl=new Scanner(System.in);
		int num=0;
		int x=(int)(Math.random()*1000+1);
		
		System.out.println("adivina el numero  ( 1 para iniciar 0 para terminar)");
		num= tcl.nextInt();
		while(num != x) {
			System.out.println("adivina el numero entre 1 y 1000 ");
			num= tcl.nextInt();
			
			if(num==x) {
				System.out.println("Congratulation as acertado");				
		}
				else if(num>x) {
						System.out.println("el numero "+num+" es mayor");
						
					
		}
				else{ 
						System.out.println("el numero "+num+" es menor");
						
			
		}
		}
}
}