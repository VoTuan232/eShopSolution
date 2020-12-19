# Tang service
- Add Project reference eShopSolution.Data to eShopSolution.App
<ProjectReference Include="..\eShopSolution.Data\eShopSolution.Data.csproj" />

- DTO, IServices, Service(Manage-Admin, Public-Client)

- async await (Task<>), task sẽ chạy tại background thay vì chờ (***)
- SaveChangesAsync: Lưu không đồng bộ tất cả các thay đổi được thực hiện trong ngữ cảnh này vào cơ sở dữ liệu bên dưới