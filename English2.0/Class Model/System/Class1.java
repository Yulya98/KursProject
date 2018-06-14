package System;


/**
 * @author Anna
 * @version 1.0
 * @created 05-май-2018 19:16:56
 */
public class Class1 extends Class2 implements Interface1 {

	public Class3 m_Class3;

	public Class1(){

	}

	public void finalize() throws Throwable {
		super.finalize();
	}
}//end Class1