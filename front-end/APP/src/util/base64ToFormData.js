// https://stackoverflow.com/questions/26667820/upload-a-base64-encoded-image-using-formdata
// https://copyprogramming.com/howto/javascript-convert-base64-image-to-formdata-code-example
// https://gist.github.com/AshikNesin/ca4ad1ff1d24c26cb228a3fb5c72e0d5
// https://www.appsloveworld.com/reactjs/100/29/how-do-you-encode-a-file-to-base64-then-upload-as-multipart-file-to-backend-api-u

// "data:image/jpeg;base64,/9j/4AAQSkZJRgABA"

import { environment } from "../environments/environment.js";

function fetchBase64File(base64File, id, role) {
  // const base64 = "data:image/png;base64,...."; // Place your base64 url here.
  const API_URL = environment.upload_avatar;
  const [fileData, base64] = base64File.split(",");
  const mimeType = fileData.split("/").at(1).split(";").at(0);
  const fileName = `${id}.${mimeType}`;

  fetch(base64)
    .then((res) => res.blob())
    .then((blob) => {
      const fd = new FormData();
      const file = new File([blob], fileName);
      fd.append("image", file);

      // Let's upload the file
      // Don't set contentType manually → https://github.com/github/fetch/issues/505#issuecomment-293064470

      fetch(API_URL, { method: "POST", body: fd })
        .then((res) => res.json())
        .then((res) => console.log(res));
    });
}
fetchBase64File("data:image/jpeg;base64,/9j/4AAQSkZJRgABA", "tes12312");
