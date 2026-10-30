using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Inserta un dato preservando la propiedad del árbol BST.
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        // Los valores repetidos no se insertan.
        return root;
    }

    // Busca un valor desde la raíz.
    public bool Search(int key)
    {
        return SearchRec(Root, key);
    }

    private bool SearchRec(Node root, int key)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Data == key)
        {
            return true;
        }

        if (key < root.Data)
        {
            return SearchRec(root.Left, key);
        }

        return SearchRec(root.Right, key);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();

        // Insertar valores en el árbol.
        int[] values = { 50, 30, 70, 20, 40, 60, 80 };

        foreach (int value in values)
        {
            tree.Insert(value);
        }

        Console.Write("Ingrese el número que desea buscar: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool found = tree.Search(number);

            if (found)
            {
                Console.WriteLine($"El número {number} se encuentra en el árbol.");
            }
            else
            {
                Console.WriteLine($"El número {number} no se encuentra en el árbol.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        }
    }
}
