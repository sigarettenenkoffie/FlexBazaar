import axios, { type AxiosInstance } from "axios";
import { API_URL } from '@/common/config';

const apiClient: AxiosInstance = axios.create({
  baseURL: API_URL,
  headers: {
    "Content-type": "application/json",
    "Access-Control-Allow-Origin": "*"
  },
});

export default apiClient;