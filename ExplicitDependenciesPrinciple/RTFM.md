# 显式依赖原则 Explicit Dependencies Principle

## 定义
方法和类应明确要求(通常通过方法参数或构造函数参数)它们所需的任何协作对象, 以便正常运行.

## 依赖项的定义
如果您的类需要其他类来执行其操作, 那么这些其他类就是依赖项. 

## 隐式依赖项的定义
如果这些依赖项仅存在于类内部的代码中, 而不存在于其公共接口中, 则它们是隐式的. 

## 显式依赖项的定义
对于类的依赖项, 显示依赖项最常出现在对象的构造函数中; 对于更多本地依赖项, 显式依赖项通常出现在特定方法的参数列表中.

## 隐式依赖的缺点
隐式依赖关系的类比具有显式依赖关系的类的维护成本更高. 它们更难测试, 因为他们与协作者的耦合更紧密. 更难以分析副作用, 因为必须搜索整个类的代码库以查找对象实例化或对静态方法的调用. 与合作者的耦合更紧密, 导致设计更加僵化和脆弱.

## 显式依赖的优点
非常清楚的说明了执行特定职能所需的条件. 它们倾向于遵循`最小意外原则`, 减少修改代码影响的范围. 无论是在生产中还是在测试或debug过程中, 显式依赖项都可以轻松的替换为其他实现. 这使得它们更容易维护并且更愿意改变.