using System.Linq;

namespace CsGls.Results
{
    /// <summary>
    /// Output transformed into a GLS command.
    /// </summary>
    public class CommandTransformation : ITransformation
    {
        /// <summary>
        /// GLS command name.
        /// </summary>
        public string CommandName { get; }

        /// <summary>
        /// Parameters passed to the command.
        /// </summary>
        public ITransformation[] Parameters { get; }

        /// <summary>
        /// Character range this transformation result applies to.
        /// </summary>
        public Range Range { get; }

        public CommandTransformation(string commandName, Range range, params ITransformation[] parameters)
        {
            this.CommandName = commandName;
            this.Range = range;
            this.Parameters = parameters;
        }

        public override string ToString()
        {
            if (this.Parameters.Length == 0)
            {
                return this.CommandName;
            }

            return $"{this.CommandName} : {this.FormatParameters()}";
        }

        private string FormatParameters()
        {
            return string.Join(
                " ",
                this.Parameters.Select(parameter => parameter.ToString()));
        }
    }
}