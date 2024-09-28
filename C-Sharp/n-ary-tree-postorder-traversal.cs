/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        IList<int> result = new List<int>();
        if (root == null) {
            return result;
        }

        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0) {
            Node node = stack.Pop();
            result.Insert(0, node.val);

            foreach (var child in node.children) {
                stack.Push(child);
            }
        }

        return result;
    }
}