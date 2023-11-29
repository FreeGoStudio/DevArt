# 状态模式(State Pattern)

```plantuml
state Open
state Close
state Cancel

[*] --> Open : 创建订单
Open -> Open : 更新数据
Open -> Close : 关闭
Close -> Open : 打开
Open --> Cancel : 取消订单
Close --> Cancel : 取消订单
```



### 定义
状态模式将对象的行为封装在不同的状态类中, 使得对象在不同状态下有不同的行为. 

### 意图
状态模式中, 一个对象在其内部状态改变时, 改变该对象的行为, 使其看起来好像修改了该类. 


### 角色
 * 上下文(Context): 维护一个具体状态对象的引用, 并在状态改变时切换到新的状态.
 * 状态(State): 定义一个接口或抽象类, 封装了特定状态下的行为.


