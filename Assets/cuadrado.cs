using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadrado : MonoBehaviour
{
    private float dx=0;
    private float dy=0;
    private float dz=0;
    private float rz=0;
    public float column;
    public float row;
    private float direccion=0; //0 es horizontal 1 es vertical
    private float movimiento=2f;
    int i = 0;
    public GameObject    objectToDuplicate;
    private void Color(GameObject objeto)
    {
        // Generar color aleatorio
    Color randomColor = new Color(Random.value, Random.value, Random.value, 1f);

    // Asignar color al material del objeto
    Renderer renderer = objeto.GetComponent<Renderer>();
    if (renderer != null)
    {
    Material material = renderer.material;
    material.color = randomColor;
    }
    }


    // Start is called before the first frame update
    void Start()
    {   
        
           for(int y=0; y<column;y++)
            {//giro 90
        
                for(int i=0; i < row; i++)
                {   

                    GameObject newObject = Instantiate(objectToDuplicate, new Vector3(dx+y%2, dy, dz), Quaternion.Euler(0, rz, 0));
                    Color(newObject);
                    dx+=2;
                    
                    
                }
                dx=0;
                dy++;
            }
            
            rz+=90;
            dy=0;
            dz=0.5f;
            dx-=0.5f;
            for(int y=0; y<column;y++)
            {//giro 90
        
                for(int i=0; i < row; i++)
                {   

                    GameObject newObject = Instantiate(objectToDuplicate, new Vector3(dx, dy, dz+(y+1)%2), Quaternion.Euler(0, rz, 0));
                    Color(newObject);
                    dz+=2;
                    
                    
                }
                dy++;
                dz=0.5f;
            }



            dx+=0.5f;
            dz+=(-0.5f)+(2*row);
            dy=0;
            rz+=90;
            for(int y=0; y<column;y++)
            {//giro 90
        
                for(int i=0; i < row; i++)
                {   

                    GameObject newObject = Instantiate(objectToDuplicate, new Vector3(dx+(y+1)%2, dy, dz), Quaternion.Euler(0, rz, 0));
                    Color(newObject);
                    dx+=2;
                    
                    
                }
                dy++;
                dx=0;
                
            }



            dx=-0.5f+(2*row);
            dy=0;
            dz=-1.5f+2*row;
            rz+=90;
             for(int y=0; y<column;y++)
            {//giro 90
        
                for(int i=0; i < row; i++)
                {   

                    GameObject newObject = Instantiate(objectToDuplicate, new Vector3(dx, dy, dz+(y%2)), Quaternion.Euler(0, rz, 0));
                    Color(newObject);
                    dz-=2;
                    
                    
                }
                dy++;
                dz=-1.5f+2*row;
            }


        
         
        
       
    





    }
                
        
    
}
    // Update is called once per frame
   

