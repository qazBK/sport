namespace sport
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exitprogram = false;


            while (!exitprogram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formMenu = new FormMenu(formLogin.CurentUser, formLogin.IsGauste))
                        {
                           
                            if (formMenu.ShowDialog() == DialogResult.OK)
                            {
                                if (formMenu.IsProduct==1)
                                {
                                    using (var formProducts = new FormProducts(formLogin.CurentUser, formLogin.IsGauste))
                                    {
                                        if (formProducts.ShowDialog() == DialogResult.Cancel)
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else if (formMenu.IsProduct == 2)
                                {
                                    using (var FormOrders = new FormOrders(formLogin.CurentUser, formLogin.IsGauste))
                                    {
                                        if (FormOrders.ShowDialog() == DialogResult.Cancel)
                                        {
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        exitprogram = true;
                    }
                }

            }
        }
    }
}
/*
 using (var formProducts = new FormProducts(formLogin.CurentUser, formLogin.IsGauste))
                        {
                            if (formProducts.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                        }
                    }
 
 */