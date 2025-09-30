export const getTeacherCount = async () => {
	const res = await fetch(
		`${import.meta.env.VITE_BACKEND_URL}/api/Teacher/count`,
		{
			headers: {
				"Content-Type": "application/json",
			},
		}
	);

	if (res.ok) {
		return res.json();
	}

	throw new Error("Failed to fetch teacher count");
};
