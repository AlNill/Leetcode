As result code beats 64.21% by runtime and 68.63% by memory.

EXPLANATION
	1. Floyd’s Cycle-Finding Algorithm // fast slow approach // 2 pointers // "tortoise and the hare algorithm"
	2. Approach: This is the fastest method and has been described below:
	3. Traverse linked list using two pointers.
	4. Move one pointer(slow_p) by one and another pointer(fast_p) by two.
	5. If these pointers meet at the same node then there is a loop. If pointers do not meet then linked list doesn’t have a loop.