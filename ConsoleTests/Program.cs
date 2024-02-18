using Easy._733.FloodFill;

var s = new Solution();
//int[][] image = new int[3][];
//for (int i = 0; i < 3; i++)
//{
//    image[i] = new int[3];
//}

//image[0][0] = 1;
//image[0][1] = 1;
//image[0][2] = 1;
//image[1][0] = 1;
//image[1][1] = 1;
//image[1][2] = 0;
//image[2][0] = 1;
//image[2][1] = 0;
//image[2][2] = 1;

//s.FloodFill(image, 1, 1, 2);

int[][] image = new int[2][];
for (int i = 0; i < 2; i++)
{
    image[i] = new int[3];
}

s.FloodFill(image, 0, 0, 0);
var a = 5;
