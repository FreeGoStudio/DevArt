# 状态模式(State Pattern)

### 应用场景
代码中包含大量与对象状态相关的条件语句.

```plantuml
state Idle
state Run
state Rise
state Fall
state Attack

[*] -> Idle
Idle -up-> Attack : 触发
Attack --> Idle : 结束
Idle -> Run : abs(x方向输入值)>=0.1
Run -> Idle : abs(x方向输入值)<0.1
Idle --> Rise : 触发
Rise --> Fall : y方向速度<-0.1
Fall --> Idle : 接触地面
Idle --> Fall : y方向速度<-0.1
```



### 定义
状态模式将对象的行为封装在不同的状态类中, 使得对象在不同状态下有不同的行为. 

### 意图
状态模式中, 一个对象在其内部状态改变时, 改变该对象的行为, 使其看起来好像修改了该类. 


### 角色
 * 上下文(Context): 维护一个具体状态对象的引用, 并在状态改变时切换到新的状态.
 * 状态(State): 定义一个接口或抽象类, 封装了特定状态下的行为.


