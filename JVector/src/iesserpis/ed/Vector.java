package iesserpis.ed;

public class Vector {

	public static void main(String[] args) {
//		int index=0;
//		
//		int[] v = new int[]{17, 12, 15, 9, 14};
//
//	//	for(index=0; index<5;index++) {
// 		//System.out.println("elemento "+index+" valor = "+ v[index]);
		int[] v = new int[]{17, 12, 15, 9, 14};
		int x=33;
		int index= indexOf(v,x);
		
		System.out.println("index "+index);
		System.out.println("fin");
	
	}
		
	public static int indexOf(int[] v, int x) {
		
		int index=0;
		while(index<v.length && v[index]!=x) 
			index++;
			if(index==v.length) { 
				return -1;
			}
			return index;
		
		
	}
	
}