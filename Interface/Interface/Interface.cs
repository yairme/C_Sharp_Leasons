using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{

    public interface ICharacterController
    {
        string this[string key] { get; set; }

        void SetCharacter(ICharacter character);

        void Logic(float frametime);

    }
    class CPUcontroller : ICharacterController
    {
        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        readonly IInputDevice movement;
        public CPUcontroller(IInputDevice movement)
        {
            this.movement = movement;

        }

        public void Logic(float frametime)
        {
            throw new NotImplementedException();
        }

        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }

    public class PlayerController : ICharacterController
    {

        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        readonly IInputDevice inputKey;
        public PlayerController(IInputDevice inputKey)
        {
            this.inputKey = inputKey;
        }

        public void Logic(float frametime)
        {
            if (inputKey.IsDown(GameButton.HIT))
            {

            }
            if (inputKey.IsDown(GameButton.DODGE))
            {

            }
            if (inputKey.IsDown(GameButton.JUMP))
            {

            }
        }

        public void SetCharacter(ICharacter character)
        {
            
            throw new NotImplementedException();
        }
    }
}
