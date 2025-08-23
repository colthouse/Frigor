export class UrlHelper {
  public static getApiBase(): string {
    let port: string = "";
    if (window.location.port != "80" && window.location.protocol == "http:" || window.location.port != "443" && window.location.protocol == "https:")
      port = ":" + window.location.port;

    return window.location.protocol + "//" + window.location.host + port + '/api/';
  }
}
