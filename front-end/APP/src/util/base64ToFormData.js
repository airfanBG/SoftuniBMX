// https://stackoverflow.com/questions/26667820/upload-a-base64-encoded-image-using-formdata
// https://copyprogramming.com/howto/javascript-convert-base64-image-to-formdata-code-example
// https://gist.github.com/AshikNesin/ca4ad1ff1d24c26cb228a3fb5c72e0d5
// https://www.appsloveworld.com/reactjs/100/29/how-do-you-encode-a-file-to-base64-then-upload-as-multipart-file-to-backend-api-u

// "data:image/jpeg;base64,/9j/4AAQSkZJRgABA"

import { environment } from "../environments/environment.js";

function fetchBase64File(file, id, role) {
  let apiRole = role === "user" ? "client" : "employee";

  // const API_URL = `https://localhost:7047/api/${apiRole}/add_avatar`;
  const API_URL = `${environment.BASE_URL}/api/${apiRole}/add_avatar`;
  // console.log(API_URL);

  const formData = new FormData();
  formData.append("Id", id);
  formData.append("Role", role);
  formData.append("ImageToSave", file);

  fetch(API_URL, {
    method: "POST",
    // mode: "cors",
    body: formData,
  })
    .then((response) => response.json())
    .then((data) => {
      console.log(data);
    })
    .catch((error) => {
      console.error(error);
    });
}

export { fetchBase64File };
