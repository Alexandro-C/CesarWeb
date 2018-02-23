namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        static string ABECEDARIO=("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string minusculas=("abcdefghijklmnñopqrstuvwxyz");



        public string DesEncriptar(string Mensaje, int clave)
        {
            clave=clave*(-1);
            int EMensaje=0,q=0;
            string funcionar = Mensaje;
            //Para recorrer los espacios dentro de mensaje
            for(q=0;q<Mensaje.Length;q++){
                ///Para encontrar en abecedario
                 for(EMensaje=0;EMensaje<=26;EMensaje++){
                     
                     if(Mensaje[q]==ABECEDARIO[EMensaje]){
                       
                         if(EMensaje+clave<0){
                         int clavedos=clave;
                         int resultado=EMensaje-clavedos;
                         int solucion=27+resultado;
                         funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[solucion]);
                     } 
                       if(EMensaje+clave>26){
                         int to=26-EMensaje+clave-1;
                         funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[to]);
                     }
                     if(EMensaje+clave==0){
                          funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[0]);
                     }
                     
                     if(EMensaje+clave>0 &&(EMensaje+clave<27))
                     { funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[EMensaje+clave]);}
                         }
                     if(Mensaje[q]==minusculas[EMensaje]){
                        
                         if(EMensaje+clave<0){
                         int clavedos=clave;
                         int resultado=EMensaje+clavedos;
                         int solucion=27+resultado;
                         funcionar=funcionar.Replace(funcionar[q],minusculas[solucion]);
                         
                     } 
                     if(EMensaje+clave>26){
                         int to=26-EMensaje+clave-1;
                         funcionar=funcionar.Replace(funcionar[q],minusculas[to]);
                     }
                     if(EMensaje+clave==0){
                          funcionar=funcionar.Replace(funcionar[q],minusculas[0]);
                     }
                     if(EMensaje+clave>0 &&(EMensaje+clave<27)){ funcionar=funcionar.Replace(funcionar[q],minusculas[EMensaje+clave]);}
                         }

                 }

                 

            }
           Mensaje=funcionar;
           
            return Mensaje;
        }




        

        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            int EMensaje=0,q=0;
            string funcionar = Mensaje;
            //Para recorrer los espacios dentro de mensaje
            for(q=0;q<Mensaje.Length;q++){
                ///Para encontrar en abecedario
                 for(EMensaje=0;EMensaje<=26;EMensaje++){
                     
                     if(Mensaje[q]==ABECEDARIO[EMensaje]){
                       
                         if(EMensaje+clave<0){
                         int clavedos=clave;
                         int resultado=EMensaje-clavedos;
                         int solucion=27+resultado;
                         funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[solucion]);
                     } 
                       if(EMensaje+clave>26){
                         int to=26-EMensaje+clave-1;
                         funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[to]);
                     }
                     if(EMensaje+clave==0){
                          funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[0]);
                     }
                     
                     if(EMensaje+clave>0 &&(EMensaje+clave<27))
                     { funcionar=funcionar.Replace(funcionar[q],ABECEDARIO[EMensaje+clave]);}
                         }
                     if(Mensaje[q]==minusculas[EMensaje]){
                        
                         if(EMensaje+clave<0){
                         int clavedos=clave;
                         int resultado=EMensaje+clavedos;
                         int solucion=27+resultado;
                         funcionar=funcionar.Replace(funcionar[q],minusculas[solucion]);
                         
                     } 
                     if(EMensaje+clave>26){
                         int to=26-EMensaje+clave-1;
                         funcionar=funcionar.Replace(funcionar[q],minusculas[to]);
                     }
                     if(EMensaje+clave==0){
                          funcionar=funcionar.Replace(funcionar[q],minusculas[0]);
                     }
                     if(EMensaje+clave>0 &&(EMensaje+clave<27)){ funcionar=funcionar.Replace(funcionar[q],minusculas[EMensaje+clave]);}
                         }

                 }

                 

            }
           Mensaje=funcionar;
            return Mensaje;

        }
    }


}