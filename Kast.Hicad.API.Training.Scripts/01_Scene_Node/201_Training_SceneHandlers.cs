// <debug /> 
// <assembly>API/System.Data.dll</assembly>

using ISD.Scripting;
using ISD.BaseTypes;
using ISD.CAD.Base;
using ISD.CAD.Contexts;
using ISD.CAD.Data;

using System.Windows.Forms;
using System.Data;
using ISD.CAD.Creators;
using ISD.Math;

namespace ApiTraining.scripts
{
    /// <summary>
    /// Eric Compen: ISD Benelux 
    /// </summary>
    class Script : ScriptBase
    {
        [Context(typeof(UnconstrainedContext))]
        public static void Main()
        {
            try
            {
                // create new scene in current slot
                Scene drawing1 = Context.NewScene("drawing1");

                // create new scene in next free slot
                Scene drawing2 = Context.NewSceneSlot("drawing2");

                

                // return to first scene
                drawing1.Activate();

                // save the first scene under current name
                drawing1.Save();

                // close the current scene
                drawing1.Close();

            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.InnerException);
            }
        }

        /// <summary>
        /// Returns the scripting context.
        /// </summary>
        public static UnconstrainedContext Context
        {
            get { return BaseContext as UnconstrainedContext; }
        }
    }
}
