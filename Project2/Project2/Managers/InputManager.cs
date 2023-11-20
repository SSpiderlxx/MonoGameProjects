
using Microsoft.Xna.Framework.Input;

namespace Project2.Managers
{
    public class InputManager
    {
        MouseState currentMS;
        MouseState previouseMS;

        public void updatePreviouseMS()
        {
            previouseMS = currentMS;
        }

        public bool OnMouseDown(int button)
        {
            switch (button)
            {
                case 0:
                    currentMS = Mouse.GetState();
                    if (currentMS.LeftButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 1:
                    currentMS = Mouse.GetState();
                    if (currentMS.RightButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 3:
                    currentMS = Mouse.GetState();
                    if (currentMS.MiddleButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                default:
                    break;
            }
            

            return false;
        }

        public bool OnMouseUp(int button)
        {
            switch (button)
            {
                case 0:
                    currentMS = Mouse.GetState();
                    if (currentMS.LeftButton == ButtonState.Released)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 1:
                    currentMS = Mouse.GetState();
                    if (currentMS.RightButton == ButtonState.Released)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 3:
                    currentMS = Mouse.GetState();
                    if (currentMS.MiddleButton == ButtonState.Released)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                default:
                    break;
            }


            return false;
        }

        public bool OnClick(int button)
        {
            switch (button)
            {
                case 0:
                    if(currentMS.LeftButton == ButtonState.Released && previouseMS.LeftButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 1:
                    if (currentMS.RightButton == ButtonState.Released && previouseMS.RightButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
                case 3:
                    if (currentMS.MiddleButton == ButtonState.Released && previouseMS.MiddleButton == ButtonState.Pressed)
                    {
                        previouseMS = currentMS;
                        return true;
                    }
                    break;
            }

            return false;
        }
    }
}
