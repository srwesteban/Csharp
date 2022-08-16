using System;

namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    // La interfaz de componente base define operaciones que pueden ser modificadas por
    // decorators.
    public abstract class Component
    {
        public abstract string Operation();
    }

    // Los componentes concretos proporcionan implementaciones predeterminadas de las operaciones.
    // Puede haber varias variaciones de estas clases.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }

    // La clase Decorator base sigue la misma interfaz que las otras
    // componentes. El propósito principal de esta clase es definir el envoltorio
    // interfaz para todos los decoradores de hormigón. La implementación por defecto de la
    // el código de envoltura puede incluir un campo para almacenar un componente envuelto y
    // los medios para inicializarlo.
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        // El decorador delega todo el trabajo al componente envuelto.
        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    // Los Decoradores de Concreto llaman al objeto envuelto y alteran su resultado en algunos
    // camino.
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        // Los decoradores pueden llamar a la implementación principal de la operación, en su lugar
        // de llamar directamente al objeto envuelto. Este enfoque simplifica
        // extensión de las clases de decoradores.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }

    // Los decoradores pueden ejecutar su comportamiento antes o después de la llamada a
    // un objeto envuelto.
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }

    public class Client
    {
        // El código del cliente funciona con todos los objetos que utilizan la interfaz de componentes.
        // De esta manera puede mantenerse independiente de las clases concretas de
        // componentes con los que trabaja.
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Cliente: obtengo un componente simple:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...así como los decorados.
            //
            // Tenga en cuenta cómo los decoradores pueden envolver no solo componentes simples sino también
            // otros decoradores también.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Cliente: Ahora tengo un componente decorado:");
            client.ClientCode(decorator2);
        }
    }
}