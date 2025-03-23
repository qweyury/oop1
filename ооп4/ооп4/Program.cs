using ооп4;
class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode("Root");
        TreeNode child1 = new TreeNode("Child1");
        TreeNode child2 = new TreeNode("Child2");

        root.AddChild(child1);
        root.AddChild(child2);

        TreeNode grandchild1 = new TreeNode("Grandchild1");
        child1.AddChild(grandchild1);

        root.PrintChildren();
    }
}
