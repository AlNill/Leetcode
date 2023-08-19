using System.Text;

namespace _67.AddBinary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder sb = new StringBuilder();

        int firstIndex = a.Length - 1;
        bool extension = false;
        for(int i = b.Length - 1; i >= 0; --i)
        {
            char sum;
            if (firstIndex < 0)
            { 
                if(!extension)
                {
                    sum = b[i];
                }
                else
                {
                    if (b[i] == '1')
                        sum = '0';
                    else
                    {
                        sum = '1';
                        extension = false;
                    }
                }                
            }
            else
            {
                if (a[firstIndex] == '0' && b[i] == '0')
                {
                    if(extension == true)
                    {
                        sum = '1';
                        extension = false;
                    }
                    else
                        sum = '0';
                }
                else if (a[firstIndex] == '0' && b[i] == '1' ||
                    a[firstIndex] == '1' && b[i] == '0')
                {
                    if (extension == true)
                    {
                        sum = '0';
                    }
                    else
                    {
                        sum = '1';
                        extension = false;
                    }
                }
                else
                {
                    if (extension == true)
                        sum = '1';
                    else
                    {
                        sum = '0';
                        extension = true;
                    }
                }
            }
            sb.Insert(0, sum);
            --firstIndex;
        }

        while (firstIndex >= 0)
        {
            char sum;
            if (!extension)
            {
                sum = a[firstIndex];
            }
            else
            {
                if (a[firstIndex] == '1')
                    sum = '0';
                else
                {
                    sum = '1';
                    extension = false;
                }
            }
            sb.Insert(0, sum);
            --firstIndex;
        }

        if(extension)
        {
            sb.Insert(0, '1');
        }
        return sb.ToString();
    }
}
