export class UserHelper{
    public SaveUuid(id:string):void{
        localStorage.setItem("uuid",id)
    }
    public GetUuid():string{
        return localStorage.getItem("uuid") ?? "";
    }
}