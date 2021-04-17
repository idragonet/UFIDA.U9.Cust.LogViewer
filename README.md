# UFIDA.U9.Cust.LogViewer
U9日志在线查看
- 功能：直接在U9查看日志和下载日志，避免登录服务器查看。


- 部署：补丁部署成功
- 菜单：在菜单：系统管理-系统日志-系统日志查看
- 菜单授权注意事项：U9默认菜单权限看不到“系统管理”模块，需要编辑文件：Portal\bin\environment.xml

`<trace iisTrace="false" sqlTrace="false" perfAlert="true" perfTrace="true" TraceFlags="ItemNameAndSPECS,PerfMonitor,DisplaySMMenu" />`
