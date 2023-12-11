import { useCallback } from "react";

const itemName = "userData";

function useUserData() {
  const data = useCallback(() => {
    JSON.parse(localStorage.getItem(itemName));
  }, []);
}

export { useUserData };
