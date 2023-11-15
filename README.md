# DLaudiochat

#### 介绍
参考了https://github.com/ewgraf/Retranslyator

基于C#和NAudio的局域网语音聊天工具

UDP通信，没有一个主机做服务端，只有客户端。双方均填入对方IP并在同一个button按下事件设置相同端口后连接即可

### ToDoList

①闭麦和静音开关打算用防火墙规则来实现，但没有起效

②压缩成mp3格式传输和播放

③UDP数据包有包头格式和传播时延
