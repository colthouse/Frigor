export class UserHelper{
    public static saveUuid(id:string):void{
        localStorage.setItem("uuid",id)
    }
    public static getUuid():string{
        return localStorage.getItem("uuid") ?? "";
    }
}