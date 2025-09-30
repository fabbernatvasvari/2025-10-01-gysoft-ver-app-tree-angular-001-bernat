import { useQuery } from "@tanstack/react-query";
import { createFileRoute } from "@tanstack/react-router";
import { getTeacherCount } from "../helpers/apiHelpers";

export const Route = createFileRoute("/")({
	component: Index,
});

function Index() {
	const { isPending, isError, data, error } = useQuery({
		queryKey: ["TeacherCount"],
		queryFn: getTeacherCount,
	});

	if (isPending) return <div>Loading...</div>;
	if (isError) return <div>Error: {JSON.stringify(error)}</div>;

	return (
		<div className="p-2">
			<h3>Teacher count: {data}</h3>
		</div>
	);
}
