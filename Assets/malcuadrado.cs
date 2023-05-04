using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malcuadrado : MonoBehaviour
{
    public GameObject objectToDuplicate;
  
    private float dx=0;
    private float dy=1;
    private float dz=0;
    private float rz=0;
    public float column=5;
    public float row=4;
    private float direccion=0; //0 es horizontal 1 es vertical
    private float movimiento=2f;
    int i = 0;
    // Start is called before the first frame update
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
    void Start()
    {
           
        for(int z=0; z<4;z++)//giro 90
        {
           for(int j=0; j<column;j++)//horizontal
           {
                for(i=0; i < row; i++)//vertical
                {   

                    GameObject newObject = Instantiate(objectToDuplicate, new Vector3(dx, dy, dz), Quaternion.Euler(0, rz, 0));
                    Color(newObject);
                    dy++;

                    
                    
                }
                dy=1;
                    switch (direccion)
                    {
                    case 0:
                    dx+=movimiento;
                    break;
                    case 1:
                    dz+=movimiento;
                    break;
                    case 2:
                    dx-=movimiento;
                    break;
                    case 3:
                    dz-=movimiento;
                    break;
                    
                }
                
            }
            switch (direccion)
                    {
                    case 0:
                    dx -= 0.5f;
                    dz += 0.5f;
                    break;
                    case 1:
                    dx -= 0.5f;
                    dz -= 0.5f;
                    break;
                    case 2:
                    dx += 0.5f;
                    dz -= 0.5f;
                    break;
                    case 3:
                    
                    break;
                    
                    }
            
            direccion=(direccion+1)%column;
            rz+=90;
            
            
        }
    
       
    }

  /****/
}