/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import Operaciones.Matematicas;
/**
 *
 * @author r_blu
 */
@WebService(serviceName = "wsPublico")
public class wsPublico {

    /**
     * Web service operation
     * @param parX
     * @param parY
     * @return 
     */
    @WebMethod(operationName = "sumar")
    public int sumar(@WebParam(name = "parX") int parX, @WebParam(name = "parY") int parY) {
        Matematicas m = new Matematicas();
        return m.suma(parX, parY);
    }
    
    /**
     * Web service operation
     * @param parX
     * @param parY
     * @return 
     */
    @WebMethod(operationName = "multiplicar")
    public int multiplicar(@WebParam(name = "parX") int parX, @WebParam(name = "parY") int parY) {
        Matematicas m = new Matematicas();
        return m.multi(parX, parY);
    }
}
