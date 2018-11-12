using System;
using System.Collections.Generic;
namespace myApp
{

    class Node {
        public int data;
        public Node left;
        public Node right;
        public Node(int data) {
            this.data = data;
        }
    }
    class BinaryTree
    {
        Node root;
        BinaryTree() {
            root = null;
        }

        static void InOrderTraversal(Node node) {
            if (node.left != null) {
                InOrderTraversal(node.left);
            }
            Console.WriteLine(" " + node.data + " ");
            if (node.right != null) {
                InOrderTraversal(node.right);
            }
        }

        static void LeftViewOfTree(Node node) {
            if (node != null) {
                Console.WriteLine(node.data);
                LeftViewOfTree(node.left);
            }
        }

        static Boolean checkIfBST(Node node, int parentData, bool left = false, bool right = false) {
            Boolean ret = true;
            if (node == null) {
                return ret;
            }
            if (left) {
                if (node.left != null && node.right != null && (node.data > parentData || node.left.data > parentData || node.right.data > parentData)) {
                    ret = false;
                    return false;
                }
            }
            if (right) {
                if (node.left != null && node.right != null && (node.data < parentData || node.left.data < parentData || node.right.data < parentData)) {
                    ret = false;
                    return false;
                }
            }
            if (node.left != null && node.right != null && (node.left.data > node.data || node.right.data < node.data)) {
                ret = false;
                return ret;
            }
            return checkIfBST(node.left, node.data, true, false) && checkIfBST(node.right, node.data, false, true);
        }

        void printInOrderTraversal() {
            InOrderTraversal(root);
        }

        void printLeftViewOfTree() {
            LeftViewOfTree(root);
        }
        static void Dhruv() {
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(100);
            bt.root.left = new Node(20);
            bt.root.right = new Node(130);
            bt.root.left.left = new Node(10);
            bt.root.left.right = new Node(170);
            // bt.printInOrderTraversal();
            // bt.printLeftViewOfTree();
            var dhruv = checkIfBST(bt.root, bt.root.data);
            Console.WriteLine(dhruv);

        }
        
    }
}