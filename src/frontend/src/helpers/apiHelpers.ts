export const getTeacherCount = async () => {
	const res = await fetch(
		`${import.meta.env.VITE_BACKEND_URL}/api/Teachers/count`
	);
	const data = await res.json();
	if (res.ok)
		return {
			success: true,
			count: data,
		};

	return {
		success: false,
		error: data,
	};
};
