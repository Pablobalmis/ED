#include <iostream>
using namespace std;
class persona
{
    public:          
        void dormir();         
        void hablar();          
        void contar(int);          
        void adquirirNombre();         
        void decirNombre();    
    private:           
    char nombre [40];
};
/**
* @brief Método que se usa para dormir al personaje. El método saca por pantalla una
* cadena de caracteres formada por una secuencia de “z”
**/
void persona::dormir()
{
    cout << "zzzzzzzzz" << endl;
}
/**
* @brief Metodo que hace hablar al personaje.
* Este metodo imprime por pantalla una cadena con el texto bla bla bla.
**/
void persona::hablar() 
{
    cout << "bla bla bla bla" << endl;
}
/**
* @brief Metodo que hace contar al personaje.
* @param limite Indica el numero hasta donde tiene que contar.
**/
void persona::contar(int limite)
{       
    for(int i=0;i <limite; i++)       
    {          
        cout << i << endl;       
    }
}
/**
* @brief Metodo que da nombre al personaje
**/
void persona::adquirirNombre()
{    
    cout << "Soy una persona. Ingrese mi nombre: ";
    cin >> nombre;
}
/**
* @brief Metodo que dice el nombre del personaje
**/
void persona::decirNombre() 
{
    cout << "Mi nombre es: " << nombre << endl;
}
int main() 
{
    int respuesta = 0;    cout << "Desea crear una persona? 1=Si, 0=No: ";    
    cin >> respuesta;    
    if(respuesta == 1)    
    {        
        persona * p = new persona();        
        cout << "Desea que vaya a dormir? 1=Si, 0=No: "; 
        cin >> respuesta;        
        if (respuesta == 1)        
        {            
            p->dormir();        
        }        
        cout << "Desea oirme contar? 1=Si, 0=No: "; 
        cin >> respuesta;        
        if (respuesta == 1)        
        {           
            p->contar(20);        
        }    
    }    
    system("pause");    
    return 0;
}