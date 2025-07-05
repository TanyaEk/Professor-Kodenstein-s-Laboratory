namespace Professor_Kodenstein_s_Laboratory
{
    public partial class Form1 : Form
    {
        //these "//" notes are just writing to remember what i did
        //you can read them if you want
        //I am making a laboratory for potions


        public Form1()
        {
            InitializeComponent();
        }

        //this is for the button to add ingredients
        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            string ingredient = txt_Ingredient.Text;

            if (ingredient != "")
            {
                list_BoxIngredients.Items.Add(ingredient.ToLower());
                txt_Ingredient.Text = "";
                // I am using .Focus(); sets focus on the specified element.
                txt_Ingredient.Focus();
            }
        }

        //this is for the brewing of course
        private void btn_BrewPotion_Click(object sender, EventArgs e)
        {
            List<string> ingredients = new List<string>();

            for (int i = 0; i < list_BoxIngredients.Items.Count; i++)
            {
                ingredients.Add(list_BoxIngredients.Items[i].ToString().ToLower());
            }

            string message = "";

            //all the possible potions
            //(when you choose and type the ingredients for the chosen potion, it willl appear and just close it and reactivate the program to add another ingredients for the other potion you choose)
            if (ingredients.Contains("������� ������") && ingredients.Contains("����� ����"))
            {
                message = "������� ���������� �� 10 ������!";
            }
            else if (ingredients.Contains("�����") && ingredients.Contains("�����"))
            {
                message = "������� ������ ������!";
            }
            else if (ingredients.Contains("�������") && ingredients.Contains("����"))
            {
                message = "������� ����������� �����... ���� �����!";
            }
            else if (ingredients.Count > 0)
            {
                //this will appear if you type random ingredients
                message = "���������� ������ �������, �� ���� ��������� �� �� ������.";
            }
            else
            {
                //of course if there are no ingredients added
                message = "�� �� ������� ������� ��������!";
            }

            //for the message to appear
            lbl_Result.Text = message;
        }
    }
}
