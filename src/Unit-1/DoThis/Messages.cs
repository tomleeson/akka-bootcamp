namespace WinTail
{
    public class Messages
    {


        #region Neutral/System messages
        public class ContinueProcessing { }
        #endregion

        #region Success Messages
        public class InputSuccess
        {
            public string Reason { get; private set; }

            public InputSuccess(string reason)
            {
                this.Reason = reason;
            }
        }
        #endregion

        #region Error Messages
        public class InputError
        {
            public string Reason { get; private set; }

            public InputError(string reason)
            {
                this.Reason = reason;
            }
        }

        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason)
            {
            }
        }

        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason)
            {

            }
        }
        #endregion

    }

}
