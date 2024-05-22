import http from "@/http-common";

/* eslint-disable */
class WhateverDataService {
  get(): Promise<any> {
    return http.get("/");
  }
}

export default new WhateverDataService();