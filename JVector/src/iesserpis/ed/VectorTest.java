package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

class VectorTest {

	
//	void indexOf() {
//		
//		int[] v= {17, 12, 15, 9, 14};
//		int x=15;
//		int index=Vector.indexOf(v, x);
//		
//		assertEquals(2, index);
//		
//		assertEquals(2, Vector.indexOf(new int[] {17, 12, 15, 9, 14}, 15));
//		assertEquals(3, Vector.indexOf(new int[] {17, 12, 15, 9, 14}, 9));
//		assertEquals(1, Vector.indexOf(new int[] {17, 12, 15, 9, 14}, 12));
//		// es lo mismo
//		assertEquals(0, Vector.indexOf(v, 17));
//		assertEquals(4, Vector.indexOf(v, 14));
//		
//		//	assertEquals(3, Vector.indexOf(v, 14));
//		assertEquals(-1, Vector.indexOf(new int[] {17, 12, 15, 9, 14}, 19));
//		
//	}
	
	@Test
	void max() {
		assertEquals (21, Vector.max((new int [] {14,21,12,9,7})));
	}
	@Test
	void selectionSort( ) {
		int[] v1 = {14, 21, 12, 7, 9};
		Vector.selectionSort(v1);
		assertArrayEquals(new int[] {7, 9, 12, 14, 21}, v1);
		
	}
}
