# DesignPatterns(设计模式)

## Introduction(介绍)
设计模式学习案例及扩展

## 23种设计模式
+ 创建型模式
	+ 单例模式（Singleton）解决的是实例化对象的个数的问题，比如抽象工厂中的工厂、对象池等，除了Singleton之外，其他创建型模式解决的都是 new 所带来的耦合关系。
    + 工厂模式（FactoryMethod）创建单个对象，在Abstract Factory有使用到。
    + 抽象工厂模式（AbstractFactoryMethod）创建一系列相互依赖对象，并能在运行时改变系列。
    + 建造者模式（Builder）将一个复杂对象的构造与它的表示分离，使得同样的构建过程可以创建不同的表示。
    + 原型模式（Prototype）通过拷贝原型来创建新的对象。
+ 结构型模式
    + 适配器模式（Adapter）注重转换接口，将不吻合的接口适配对接 
    + 桥接模式（Bridge）注重分离接口与其实现，支持多维度变化 
    + 组合模式（Composite）注重统一接口，将“一对多”的关系转化为“一对一”的关系 
    + 装饰者模式（Decorator）注重稳定接口，在此前提下为对象扩展功能 
    + 外观模式（Facade）注重简化接口，简化组件系统与外部客户程序的依赖关系 
    + 享元模式（Flyweight）注重保留接口，在内部使用共享技术对对象存储进行优化 
    + 代理模式（Proxy）注重假借接口，增加间接层来实现灵活控制
+ 行为型模式
    + 模板方法模式（TemplateMethod）：封装算法结构，定义算法骨架，支持算法子步骤变化。
    + 命令模式（Command）：注重将请求封装为对象，支持请求的变化，通过将一组行为抽象为对象，实现行为请求者和行为实现者之间的解耦。
    + 迭代器模式（Iterator）：注重封装特定领域变化，支持集合的变化，屏蔽集合对象内部复杂结构，提供客户程序对它的透明遍历。
    + 观察者模式（Observer）：注重封装对象通知，支持通信对象的变化，实现对象状态改变，通知依赖它的对象并更新。
    + 中介者模式（Mediator）：注重封装对象间的交互，通过封装一系列对象之间的复杂交互，使他们不需要显式相互引用，实现解耦。
    + 状态模式（State）：注重封装与状态相关的行为，支持状态的变化，通过封装对象状态，从而在其内部状态改变时改变它的行为。
    + 策略模式（Stragety）：注重封装算法，支持算法的变化，通过封装一系列算法，从而可以随时独立于客户替换算法。
    + 责任链模式（ChainOfResponsibility）：注重封装对象责任，支持责任的变化，通过动态构建职责链，实现事务处理。
    + 访问者模式（Visitor）：注重封装对象操作变化，支持在运行时为类结构添加新的操作，在类层次结构中，在不改变各类的前提下定义作用于这些类实例的新的操作。
    + 备忘录模式（Memento）：注重封装对象状态变化，支持状态保存、恢复。
    + 解释器模式（Interpreter）：注重封装特定领域变化，支持领域问题的频繁变化，将特定领域的问题表达为某种语法规则下的句子，然后构建一个解释器来解释这样的句子，从而达到解决问题的目的。
    
## 设计模式组合使用