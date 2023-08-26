As result code beats 97.29% by runtime and 56.55% by memory.

Inorder traversal is defined as a type of tree traversal technique which follows the Left-Root-Right pattern, such that:
	1. The left subtree is traversed first
	2. Then the root node for that subtree is traversed
	3. Finally, the right subtree is traversed

Subcode:
	Inorder(root):
	1. Follow step 2 to 4 until root != NULL
	2. Inorder (root -> left)
	3. Write root -> data
	4. Inorder (root -> right)
	5. End loop