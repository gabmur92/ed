package iesserpis.ed;

public class Vector {

	public static void main(String[] args) {
//		int[] v = new int[]{14, 21, 12, 7, 9};
//		int x=33;
//		int index= indexOf(v,x);
//		
//		System.out.println("index "+index);
//		
//		System.out.println("fin");
//	
//	}		
//	public static int indexOf(int[] v, int x) {
//
//		for(int index=0; index < v.length; index++)
//			if(v[index]==x)
//				return index;
//		return -1;
	}
	
	public static int max(int[] v){
		int max=v[0];
		for(int i=1; i<v.length; i++) {
			
			if(v[i] > max) 
				max = v[i];		
		}
		return max;
		
	}
	public static int selectionSort(int[] v){
		int min=0;
		int aux;
		for(int i=1; i<v.length; i++) {	
			if(v[i] >min ) 
				aux=min;
				min = v[i];		
		}
		return ;
		
	}
}
