import { get } from "../util/api.js";

async function usePagination(url, count) {
  // const dataArray = [];

  const data = await get(url);

  // for (let i = 0; i < data.length; i += count) {
  //   const chunk = data.slice(i, i + count);
  //   dataArray.push(chunk);
  // }

  return data;
}

export { usePagination };
