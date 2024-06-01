import http from "@/http-common";

/* eslint-disable */
class WhateverDataService {
  get(): Promise<any> {
    return http.get("/whatever");
  }
}

export default new WhateverDataService();