using Efficiency.Samples.Matrix;
using Efficiency.Samples.Model;

namespace Efficiency.Samples
{
    public class EffMatrixSamples
    {
        public void Builder()
        {
            //нашел доказетельство, при котором матрица решений является деревом решений
            //все просто: вес узла должно быть больше суммы весов дочерних узлов
            //матрица все же гибче
            //инкапсуляция контекста для принятия решения
            var context = new FtPlanContext();
            //fluent api - код должен быть читабельный. Debug-люди не любят данный подход
            //Скрыта все реализация. Но абсрактная модель!!!
            var matrix = new FtPlanBuilder()
                 .UseSum() // Использовать сумму, в качестве функции эффективности
                 .AddIndicator(5, WasInSectorInLast) // Был в предыдем секторе
                 .Build(); 

            //получение эффективного варианта
            var employee = matrix.GetEffectiveVar(context);
        }

        public static double WasInSectorInLast(Employee e, FtPlanContext context)
        {
            return 0;
        }
    }
}
