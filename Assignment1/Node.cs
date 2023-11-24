using System;

//create the class node
public class Node<T>{

    //decreare variables
    public T Data;
    public Node<T>? Left;
    public Node<T>? Right;

    public Node(T data)
    {
        Data = data;
        Left = Right = null;
    }
}
